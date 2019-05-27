using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockDatabase;

namespace StockDatabaseDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dc = new DataContext())
            {
                dc.Database.EnsureDeleted();
                dc.Database.EnsureCreated();

                #region 预设数据
                //dc.Reservations.AddRange(new[]
                //{
                //    new Reservation{
                //        CheckInDate = "2018/09/30",
                //        HotelId = "800800",
                //        Mobile = "18311046440",
                //        ReservationBy = "Liu, Zhenhua",
                //        ReservationNo = "CC201809111001",
                //        CreateDate = "2018/09/11"
                //    },
                //});
                //dc.Authentications.AddRange(new[]
                //{
                //    new Authentication
                //    {
                //        HotelId = "800800",
                //        Mobile = "13240137763",
                //        ReservationNo = "CC201809111001",
                //        VerificationCode = "214671",
                //        Expiration = DateTime.Parse("2018/09/21 10:21:30")
                //    }
                //});
                dc.SaveChanges();
                #endregion
                try
                {
                    //Console.WriteLine($"{dc.Users.Count()}");
                    //Console.WriteLine($"{dc.Reservations.Count()}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
