using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.ViewsModels
{
    internal class BMIViewModel
    {
        public Models.BMIModel BMIModel { get; set; }
        public BMIViewModel() {
            BMIModel = new Models.BMIModel();
            BMIModel.Height = 100;
            BMIModel.Weight = 100;
        }
    }
}
