using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Supply_business.Classes
{
    public static class SerializationHelper
    {
        public static void SerializeGoods(List<Good> goods, string filePath)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, goods);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }

        public static List<Good> DeserializeGoods(string filePath)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Good>)formatter.Deserialize(fileStream);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }

}
