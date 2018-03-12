using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUtauVS
{
    public class UstToClass
    {        
        public UstToClass(string path, ref ustFile ust)
        {
            int i = 0000;
            try
            {
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //ВСЁ ПЕРЕДЕЛАТЬ К ЧЕРТЯМ
                //ЗАМЕНИТЬ SUBSTRING НА String.Split С СЕПАРАТОРОМ "="

                using (StreamReader sr = new StreamReader(path))
                {                    
                    String line = sr.ReadToEnd();


                    if (line.Contains("UstVersion=")==true)
                    {                        
                        ust.Version = Convert.ToDouble(line.Substring(line.IndexOf("=")+1, line.Length-1));
                    }

                    if (line.Contains("Tempo=") == true)
                    {
                        ust.Tempo = Convert.ToDouble(line.Substring(line.IndexOf("=")+1, line.Length - 1));
                    }

                    if (line.Contains("ProjectName=") == true)
                    {
                        ust.PjName = line.Substring(line.IndexOf("=")+1, line.Length - 1);
                    }

                    if (line.Contains("VoiceDir=") == true)
                    {
                        ust.VoicePath = line.Substring(line.IndexOf("=")+1, line.Length - 1);
                    }

                    if (line.Contains("OutFile=") == true)
                    {
                        ust.OutFile = line.Substring(line.IndexOf("=") + 1, line.Length - 1);
                    }

                    if (line.Contains("CacheDir=") == true)
                    {
                        ust.Cache = line.Substring(line.IndexOf("=") + 1, line.Length - 1);
                    }

                    if (line.Contains("Tool1=") == true)
                    {
                        ust.Tool1 = line.Substring(line.IndexOf("=") + 1, line.Length - 1);
                    }

                    if (line.Contains("Tool2=") == true)
                    {
                        ust.Tool2 = line.Substring(line.IndexOf("=") + 1, line.Length - 1);
                    }

                    if (line.Contains("Flags=") == true)
                    {
                        ust.Flags = line.Substring(line.IndexOf("=") + 1, line.Length - 1);
                    }                    

                    if (line.Contains("Mode2=") == true)
                    {
                        ust.Mode2 = Convert.ToBoolean(line.Substring(line.IndexOf("=") + 1, line.Length - 1));
                    }

                    if (line.Contains("Autoren=") == true)
                    {
                        ust.Autoren = Convert.ToBoolean(line.Substring(line.IndexOf("=") + 1, line.Length - 1));
                    }

                    if (line.Contains("MapFirst=") == true)
                    {
                        ust.MapFirst = Convert.ToBoolean(line.Substring(line.IndexOf("=") + 1, line.Length - 1));
                    }

                    if (line.Contains(i.ToString()) == true)
                    {
                        //ust.Notes[i].Notenum
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }








        }
        




    }
}
