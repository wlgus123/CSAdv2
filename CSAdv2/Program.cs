using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAdv2
{
    internal class Program
    {
        class Dummy : IDisposable
        {
            public void Dispose() {
                Console.WriteLine("Dummy 객체의 Dispose() 호출");
            }
        }
        class Product : IComparable<Product>
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(Product other)
            {
                return this.Name.CompareTo(other.Name);
            } 

            // ToString() 구현
            public override string ToString()
            {
                return string.Format("Name: {0}, Price: {1}", Name, Price);
            }
        }

        static void Main(string[] args)
        {
            // Product의 리스트 생성하기
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "감자", Price = 1000 },
                new Product() { Name = "고구마", Price = 1400 },
                new Product() { Name = "양파", Price = 1200 },
                new Product() { Name = "당근", Price = 1600 },
                new Product() { Name = "고추", Price = 1800 }
            };
            products.Sort();    // 정렬

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            using (Dummy dummy = new Dummy())
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
