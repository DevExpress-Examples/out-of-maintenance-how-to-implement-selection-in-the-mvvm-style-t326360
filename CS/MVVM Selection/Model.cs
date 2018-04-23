using System.Collections.Generic;

namespace MVVM_Selection.Model {
    public class CountryStatisticInfo {
        readonly string name;
        readonly double area;
        readonly List<PopulationStatisticByYear> statistics;

        public string Name
        {
            get { return name; }
        }
        // Measured in millions of square kilometers.
        public double Area
        {
            get { return area; }
        }
        public List<PopulationStatisticByYear> PopulationDynamics
        {
            get { return statistics; }
        }
        public CountryStatisticInfo(string name, double area, List<PopulationStatisticByYear> statistics) {
            this.name = name;
            this.area = area;
            this.statistics = statistics;
        }
    }

    public class PopulationStatisticByYear {
        int year;
        double populationMillionsOfPeople;
        double urbanPercent;

        public int Year
        {
            get { return year; }
        }
        // Measured in Millions of people.
        public double Population
        {
            get { return populationMillionsOfPeople; }
        }
        public double UrbanPercent
        {
            get { return urbanPercent; }
        }
        public double RuralPercent
        {
            get { return 100 - urbanPercent; }
        }

        public PopulationStatisticByYear(int year, double populationMillionsOfPeople, double urbanPercent) {
            this.year = year;
            this.populationMillionsOfPeople = populationMillionsOfPeople;
            this.urbanPercent = urbanPercent;
        }
    }
}
