using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,ColorId=12314,BrandId=35,DailyPrice=350,ModelYear=2021,Description="Yeni Polo 1.0 80 PS Manuel Impression"},
                new Car{CarId=2,ColorId=12315,BrandId=12,DailyPrice=400,ModelYear=2021,Description="C3 FEEL 1.2 PureTech 83 BVM S&S 5 İleri Manuel"},
                new Car{CarId=3,ColorId=12316,BrandId=10,DailyPrice=400,ModelYear=2021,Description="Yeni Sandero Prestige 1.0 Turbo X-tronic 90 bg"}
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.FirstOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetByBrandId( int brandId )
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.FirstOrDefault(c=>c.CarId==car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            

        }
    }
}
