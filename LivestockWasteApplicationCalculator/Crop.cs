using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivestockWasteApplicationCalculator
{
    public class Crop
    {
        private string _cropName;
        private string _unit;
        private int _cropNRequirement;
        private int _cropP2O5Removal;
        private string _cropType;
        private int _prevCropAdjustment;
        private int _cropYieldGoal;
        private string _cropSeason;
        private string _year;

        public Crop(string cropName, int cropNRequirement, int cropP2O5Removal, string cropSeason, string cropType, int cropYieldGoal, int prevCropAdjustment, string unit, string year)
        {
            throw new System.NotImplementedException();
        }

        public string DisplayCropInfo()
        {
            throw new System.NotImplementedException();
        }

        public double CalculateP2O5Removal()
        {
            throw new System.NotImplementedException();
        }

        public double CalculateNRequirement()
        {
            throw new System.NotImplementedException();
        }
    }
}