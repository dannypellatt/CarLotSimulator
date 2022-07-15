using System;
namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public string silence = "of silence";
        public bool IsElectric { get; set; }

        public string MakeEngineNoise(bool isElectric, bool IsDriveable, string EngineNoise)
        { 
            if (isElectric == false)
            {
                if (IsDriveable == true)
                {
                    return EngineNoise;
                }
                else
                {
                    return silence;
                }
            }
            else
            {
                if (IsDriveable == true)
                {
                    return silence;
                }
                else
                {
                    return EngineNoise;
                }
            }


            
            
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.Write(HonkNoise); 
        }

        public string IsWorking(bool IsDriveable)
        {
            if (IsDriveable == true)
            {
                return "is currently working nicely";
            }
            else
            {
                return "is not currently working";
            }
        }
    }
}

