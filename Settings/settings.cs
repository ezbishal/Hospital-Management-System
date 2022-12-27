using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Classes;

namespace Settings
{
    public class settings
    {
        public static void createFile(string file, int status, string ds, string db, string username=null, string password=null)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file;

                string s = "";
                if(status == 1)
                {
                    s = "Data Source = " + ds + ";Initial Catalog=" + db + ";Integrated Security=true;MultipleActiveResultSets=true"; 
                }
                else if(status == 0)
                {
                    s = "Data Source = " + ds + ";Initial Catalog=" + db + ";User ID="+username+";Password="+password+"MultipleActiveResultSets=true";
                }
                File.WriteAllText(path, s);
                MainClass.showMessage("Settings saved successfully.", "success");
        }
        
    }
}
