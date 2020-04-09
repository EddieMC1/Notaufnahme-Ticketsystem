using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notaufnahme_Ticketsystem
{
    class DBHandler : Uebersicht
    {
        // Datenfelder
        private List<Logindaten> logindata;
        private static String schluessel1;
        private static String schluessel2;

        // Konstruktor
        public DBHandler()
        {
            this.logindata = new List<Logindaten>();
            schluessel1 = "5678";
            schluessel2 = "1234";
        }

        // Getter/Setter
        internal List<Logindaten> LoginData { get => logindata; set => logindata = value; }

        // Methoden
        public void GetDB()
        {
            logindata.Clear();
            MySqlConnection dbConnect;

            try
            {
                string connectString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = logindatabase";

                dbConnect = new MySqlConnection(connectString);

                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT id, vorname, nachname, benutzer, DES_DECRYPT(passwort,'" + schluessel2 + "') FROM logindata";

                    using (MySqlCommand command = new MySqlCommand(sql, dbConnect))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string empty = "";

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    empty += reader.GetString(i) + ";";
                                }

                                logindata.Add(new Logindaten(Convert.ToInt32(empty.Split(';')[0]), empty.Split(';')[1], empty.Split(';')[2], empty.Split(';')[3], empty.Split(';')[4], empty.Split(';')[5]));
                            }

                        }
                    }
                }
                dbConnect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SetDB(String neuerVorname, String neuerNachname, String neuesPersonal, String neuerBenutzer, String neuesPasswort)
        {
            // Erste Verschlüsselung noch vor dem Speichern in DB
            string encPass = EncryptMessage(neuesPasswort, schluessel1);

            MySqlConnection dbConnect;

            string connectString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = logindatabase";

            dbConnect = new MySqlConnection(connectString);

            try
            {
                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    string insertSql = "INSERT INTO logindata (vorname, nachname, personal, benutzer, passwort) VALUES (" + "'" + neuerVorname + "'"
                        + ", " + "'" + neuerNachname + "'" + ", " + "'" + neuesPersonal + "'" + ", " + "'" + neuerBenutzer + "'"
                        + ", " + "DES_ENCRYPT('" + encPass + "','" + schluessel2 + "')" + ")";

                    MySqlCommand command = new MySqlCommand(insertSql, dbConnect);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                dbConnect.Close();
            }
        }

        public void LoescheDatensatz(int index)
        {
            MySqlConnection dbConnect;

            string connectString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = logindatabase";

            dbConnect = new MySqlConnection(connectString);

            try
            {
                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    string insertSql = "DELETE FROM logindata WHERE id = " + index + ";";

                    MySqlCommand command = new MySqlCommand(insertSql, dbConnect);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                dbConnect.Close();
            }
        }

        public int GetId()
        {
            MySqlConnection dbConnect;

            try
            {
                string connectString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = logindatabase";

                dbConnect = new MySqlConnection(connectString);

                dbConnect.Open();

                string empty = "";

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT MAX(id) FROM logindata";

                    using (MySqlCommand command = new MySqlCommand(sql, dbConnect))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    empty += reader.GetString(i) + ";";
                                }
                            }
                        }
                    }
                }
                dbConnect.Close();

                return Convert.ToInt32(empty);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        /// <summary>
        /// Diese Methode verschlüsselt den mitgegebenen String
        /// </summary>
        /// <param name="plainMessage">Zu verschlüsselnder String</param>
        /// <param name="password">Passwort mit dem der String verschlüsselt werden soll</param>
        /// <returns>Den verschlüsselten String</returns>
        public string EncryptMessage(string plainMessage, string password)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.IV = new byte[8];
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[0]);
            des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, new byte[8]);
            MemoryStream ms = new MemoryStream(plainMessage.Length * 2);
            CryptoStream encStream = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainMessage);
            encStream.Write(plainBytes, 0, plainBytes.Length);
            encStream.FlushFinalBlock();
            byte[] encryptedBytes = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(encryptedBytes, 0, (int)ms.Length);
            encStream.Close();
            //MessageBox.Show(Convert.ToBase64String(encryptedBytes));
            return Convert.ToBase64String(encryptedBytes);
        }

        /// <summary>
        /// Diese Methode entschlüsslt den mitgegebenen String
        /// </summary>
        /// <param name="encryptedBase64">zu entschlüsselnder string</param>
        /// <param name="password">Passwort mit dem der String verschlüsselt wurde</param>
        /// <returns>Den entschlüsslten string</returns>
        public string DecryptMessage(string encryptedBase64, string password)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.IV = new byte[8];
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[0]);
            des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, new byte[8]);
            byte[] encryptedBytes = Convert.FromBase64String(encryptedBase64);
            MemoryStream ms = new MemoryStream(encryptedBase64.Length);
            CryptoStream decStream = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
            decStream.FlushFinalBlock();
            byte[] plainBytes = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(plainBytes, 0, (int)ms.Length);
            decStream.Close();
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
