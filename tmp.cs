        public class Log
        {
            public static void Sql(string query)
            {
                string content = ">\r\n" + DateTime.Now + "\r\n" + query;
                try
                {
                    System.IO.File.AppendAllText(@"lib\log\sql", content);
                }
                catch (Exception ex) { }
            }
        }