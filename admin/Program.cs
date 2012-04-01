using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace admin
{
    public class Program
    {
        static char[] alpha = {
                                        'a', 'b', 'c', 'd', 
                                        'e', 'f', 'g', 'h',
                                        'i', 'j', 'k', 'l',
                                        'm', 'n', 'o', 'p',
                                        'q', 'r', 's', 't', 
                                        'u', 'v', 'w', 'x',
                                        'y', 'z', '1', '2',
                                        '3', '4', '5', '6',
                                        '7', '8', '9', '&', '@'
                              };
        private const bool RUN = (true);
        private static string MASTER = Environment.MachineName.ToString();
        private static string CONSOLEPATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/kadmin/";
        public const char NEWLN = ('\n');
        private const char BLANK = ('\0');
        private static string UID, PASSWORD, NAME, UPATH, QUESTION;
        public static void Main()
        {
                run();
        }

        static void run()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/kadmin/"))
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/kadmin/");
            Environment.CurrentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/kadmin/";
            string data = string.Empty;
            while (RUN)
            {
                csout("master@" + MASTER + BLANK + ">>" + BLANK);
                csin(ref data);
                eval(data);
            }
        }

        static string csout(string s)
        {
            System.Console.Write(s.ToString());
            return s;
        }

        static void csin(ref string i) { i = System.Console.ReadLine(); }
        static void csin() { System.Console.ReadLine(); }

        static void eval(string input)
        {
            if (input == "exit")
                Environment.Exit(0);
            else if (input == "start")
                ExecCmd(Environment.CurrentDirectory + "\\console.exe");
            else if ((input.IndexOf("cd")) == 0)
            {
                string dir = input.Substring(3);
                try { Environment.CurrentDirectory += "\\" + dir + "\\"; }
                catch
                {
                    csout("Could not enter '" + dir + "'" + NEWLN);
                }
            }
            else if (input == "current")
                csout(Environment.CurrentDirectory + NEWLN);
            else if (input.IndexOf("touch") == 0)
            {
                string file = input.Substring(6);

                using (System.IO.StreamWriter touch = new System.IO.StreamWriter(Environment.CurrentDirectory + "\\" + file.ToString()))
                {
                    touch.Write(string.Empty);
                    touch.Dispose();
                }
            }
            else if (input.IndexOf("delete") == 0)
            {
                string target = input.Substring(7);
                try
                {
                    File.Delete(target.ToString());
                }
                catch
                {
                    csout("Error: " + target.ToString() + " could not be deleted." + NEWLN);
                }
            }
            else if (input.IndexOf("mkdir") == 0)
            {
                string dir = input.Substring(6);
                try
                {
                    Directory.CreateDirectory(dir.ToString());
                }
                catch
                {
                    csout("Error: " + dir.ToString() + " could not be created." + NEWLN);
                }
            }

            else if (input.IndexOf("copy") == 0)
            {
                string cut = input.Substring(5);
                string[] arr = cut.Split(' ');
                try
                {
                    File.Copy(arr[0], arr[1]);
                }
                catch
                {
                    csout("Cannot copy '" + arr[0] + "' to '" + arr[1] + "'" + NEWLN);
                }
            }

            else if (input.IndexOf("dlist") == 0)
            {
                string[] ff = Directory.GetFiles(@Environment.CurrentDirectory);
                for (int count = 0; count < ff.Count(); count++)
                    csout(ff[count] + NEWLN);
            }

            else if (input.IndexOf("printf") == 0)
                csout(input.Substring(7) + NEWLN);
            else if (input == "clear")
                Console.Clear();
            else if (input.IndexOf("open") == 0)
            {
                ExecCmd(input.Substring(5));
            }
            else if (input == "user_setup")
            {
                try
                {
                    /* private, unlisted function */
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/kadmin/" + "user.datab"))
                    {
                    user_input:
                        csout("USER SETUP\n=====================================\n");
                        csout("ENTER USER-NAME OF CHOICE (lowercase only): ");
                        csin(ref UID);
                        char[] data = UID.ToCharArray();                    
                        for (int i = 0; i < data.Count(); i++)
                        {
                            if (char.IsUpper(data[i]) == true)                            
                                goto user_input;
                            
                            for (int j = 0; j < alpha.Count() - 2; j++)
                                if (char.IsLower(data[i]) == true && data[i] == alpha[j])
                                    writer.Write(alpha[j + 2]);
                        }
                        writer.Write(NEWLN);
                    enter_password:
                        csout("ENTER NEW PASSWORD (lowercase only): ");
                        csin(ref PASSWORD);
                        char[] passd = PASSWORD.ToCharArray();
                        for (int i = 0; i < passd.Count(); i++)
                        {
                            if (char.IsUpper(passd[i]) == true)
                                goto enter_password;

                            for (int j = 0; j < alpha.Count() - 2; j++)
                                if (char.IsLower(passd[i]) == true && passd[i] == alpha[j])
                                    writer.Write(alpha[j + 2]);
                        }
                        writer.Write(NEWLN);
                        csout("ENTER A NAME (reference only, not of any significant importance): ");
                        csin(ref NAME);
                        writer.Write(NAME);
                        writer.Dispose();
                    }
                }
                catch
                {
                    csout("Unhandled error. Please try again");
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/kadmin/" + "user.datab");
                }
                csout("System paused, waiting for termination...");
                csin();
                Environment.Exit(0);
            }
        }

        

        public static string ExecCmd(string cmd)
        {
            /**
             * http://www.codeproject.com/KB/cs/Execute_Command_in_CSharp.aspx
             * 
             * Thanks to CodeProject!
             * 
             */

            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                   new System.Diagnostics.ProcessStartInfo("cmd", "/c " + cmd);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                return result;

            }
            catch (Exception objException)
            {
                // Log the exception
                return "caught "+ objException.ToString();
            }

        }

        
       
    }
}
