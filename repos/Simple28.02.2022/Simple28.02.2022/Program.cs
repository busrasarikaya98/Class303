using System;

namespace Simple28._02._2022
{   class User
    //CONSTRUCTOR(YAPICI METHODLAR) her klasın default olarak boş parametresiz constructorı mevcuttur
    //eğer custom constructor eklenirse classın instance ı oluşturulurken cons da belirlenen parametreler kullanılabilir
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    class Program
    {
        //for(int i=1; i<6; i++)
        //    {
        //     Console.WriteLine(i);
        //    }
        //FOR DÖNGÜSÜ BENZERİ CUSTOM LOOP
        
        public static void CustomLoop(int start,int end)
        {
        CustomLoop(1,100);
        startCode:
            Console.WriteLine(start.ToString());
            start++;
         if(start<end)
            goto startCode;
        }
    }
}
