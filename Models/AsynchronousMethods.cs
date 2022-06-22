using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_15
{
    public class AsynchronousMethods
    {
        private string _helloFile = @"C:\Users\Timmy\OneDrive\Рабочий стол\A-Level\Новая папка\HW_15\Files\Hello.txt";
        private string _worldFile = @"C:\Users\Timmy\OneDrive\Рабочий стол\A-Level\Новая папка\HW_15\Files\World.txt";

        public string? Hello { get; set; }
        public string? World { get; set; }

        public async void ReadHelloAsync()
        {
            await Task.Run(async () =>
            {
                Hello = await File.ReadAllTextAsync(_helloFile);
            });
        }

        public async void ReadWorldAsync()
        {
            await Task.Run(async () =>
            {
                World = await File.ReadAllTextAsync(_worldFile);
            });
        }

        public async void Display()
        {
            ReadHelloAsync();
            ReadWorldAsync();
            await Task.Run(async () =>
            {
                await Task.Delay(1000);
                Console.WriteLine(Hello + " " + World);
            });
        }
    }
}
