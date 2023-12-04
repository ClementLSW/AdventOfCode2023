// See https://aka.ms/new-console-template for more information
namespace AOC23{
    public class Program{
        public static void Main(string[] args){
            switch(args[0]){
                case "1.1":
                    Chall_1_1.Solve();
                    break;
                case "1.2":
                    Chall_1_2.Solve();
                    break;
            }
        }
    }
}
