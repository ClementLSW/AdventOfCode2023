using System;
using System.IO;
using System.Text;

namespace AOC23
{
    public class Chall_1_1{

        public static void Solve(){
            int sum = 0;
            List<int> buffer = new List<int>();

            try{
                using(StreamReader sr = GetInput(Directory.GetCurrentDirectory() + "/data/chall_1_1/input.txt")){
                    string line = sr.ReadLine();
                    while(line != null){
                        buffer.Clear();
                        foreach (char c in line){
                            if(char.IsDigit(c)){
                                buffer.Add((int)char.GetNumericValue(c));
                            }
                        }
                        int n = int.Parse(buffer.First().ToString() + buffer.Last().ToString());
                        sum += n;
                        line = sr.ReadLine();
                    }
                }
            }
            catch(FileNotFoundException ex){
                Console.WriteLine("File Not Found: " + ex.Message);
            }
            catch (IOException ex){
                Console.WriteLine("IO Exception: " + ex.Message);
            }
            catch(Exception ex){
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine("Sum: " + sum);

        }

        public static StreamReader GetInput(string filepath) {
            Console.WriteLine("Reading from: " + filepath);
            StreamReader sr = new StreamReader(filepath);
            return sr;
        }

        public void GenerateNumber(){
                        
        }
    }
}