using System.IO;

namespace Ejogos.Models
{
    public class EjogosBase
    {
        string path = "/database/jogos.csv";
        public void CreateFolderAndFile( string path)
        {

            string folder = path.Split('/')[0];
            string file = path.Split('/')[1];

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(folder);
            
            }

            if (!File.Exists(path)){
                File.Create(path);
            }

        }



    }
}
