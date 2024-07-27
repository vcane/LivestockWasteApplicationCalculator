using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivestockWasteApplicationCalculator
{
    public class Field
    {
        private string _fieldName;
        private string _location;
        private double _spreadableAcreage;
        private string _applicationType;
        private ApplicationRateLimitation _applicationRateLimitation;
        private CropRotation _cropRotation;
        private SoilNutrients _soilNutrients;
        private bool _prevManureApplied;
        private string _applicationMethod;
        private string _applicationTiming;

        public Field(string fieldName, string location, double spreadableAcreage, string applicationType, ApplicationRateLimitation applicationRateLimitation, CropRotation cropRotation, SoilNutrients soilNutrients, bool prevManureApplied, string applicationMethod, string applicationTiming)
        {
            _fieldName = fieldName;
            _location = location;
            _spreadableAcreage = spreadableAcreage;
            _applicationType = applicationType;
            _applicationRateLimitation = applicationRateLimitation;
            _cropRotation = cropRotation;
            _soilNutrients = soilNutrients;
            _prevManureApplied = prevManureApplied;
            _applicationMethod = applicationMethod;
            _applicationTiming = applicationTiming;
        }

        public void DisplayFieldInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}