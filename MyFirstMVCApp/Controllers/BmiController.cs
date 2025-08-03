using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Controllers
{
    public class BmiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new FormModel());
        }

        [HttpPost]
        public IActionResult Index(FormModel model, string action)
        {
            if (action == "CalculateBMI")
            {
                model.BMIResult = CalculateBMI(model.Height, model.Weight);

                if (model.BMIResult < 18.5)
                    model.Category = "過輕";
                else if (model.BMIResult < 24)
                    model.Category = "正常";
                else if (model.BMIResult < 27)
                    model.Category = "過重";
                else
                    model.Category = "肥胖";
            }
            else if (action == "CalculateBMR")
            {
                model.BMRResult = CalculateBMR(model.Height, model.Weight, model.Age, model.Gender);
                
                //return View(model);
            }
            /*
            else if (action == "Reset")
            {
                FormModel empty_M = new FormModel();
                ModelState.Clear(); // ← 這行確保輸入欄位不會出現舊值
                return View(empty_M);
            }
            */
            model.IsSubmitted = true;
            return View(model);
        }

        private double CalculateBMI(double height, double weight)
        {
            if (height <= 0 || weight <= 0)
                return 0;

            // 身高由 cm 轉成 m
            double heightInMeters = height / 100.0;
            double bmi = weight / (heightInMeters * heightInMeters);
            return Math.Round(bmi, 2); // 四捨五入到小數點第二位
        }

        private double CalculateBMR(double height, double weight, int age, string gender)
        {
            if (height <= 0 || weight <= 0 || age <= 0)
                return 0;

            double bmr;

            if (gender == "M") // 男性
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
            else // 女性
                bmr = 10 * weight + 6.25 * height - 5 * age - 161;

            return Math.Round(bmr, 2);
        }
    }
}
