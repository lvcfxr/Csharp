namespace DeliveryCostCalculator
{
    using System;

    // Делегат для обчислення вартості доставки
    public delegate double DeliveryCostDelegate(double weight, double distance, string deliveryType, double volume);

    public class Program
    {
        public static void Main()
        {
            // Приклад даних
            double weight = 25.0;   // вага в кг
            double distance = 100.0; // відстань в км
            string deliveryType = "standard"; // тип доставки
            double volume = 30.0;    // об'єм у кубічних метрах

            // Делегати для різних типів доставки через лямбда-вирази
            DeliveryCostDelegate standardCostDelegate = (w, d, t, v) =>
            {
                double baseCost = w * d * 0.5;
                double multiplier = t == "express" ? 1.5 : 1.0;
                return baseCost * multiplier;
            };
            DeliveryCostDelegate discountedCostDelegate = (w, d, t, v) =>
            {
                double baseCost = w * d * 0.5;
                double discount = t == "discounted" ? 0.5 : 1.0;
                return baseCost * discount;
            };
            DeliveryCostDelegate volumeCostDelegate = (w, d, t, v) =>
            {
                double baseCost = w * d * 0.5;
                double volumeCost = v * 2.0;
                return baseCost + volumeCost;
            };

            // Виклик методів через делегати
            double standardCost = standardCostDelegate(weight, distance, deliveryType, volume);
            double discountedCost = discountedCostDelegate(weight, distance, deliveryType, volume);
            double volumeBasedCost = volumeCostDelegate(weight, distance, deliveryType, volume);

            // Виведення результату
            Console.WriteLine($"The total delivery cost for standard delivery is: {standardCost}");
            Console.WriteLine($"The total delivery cost for discounted delivery is: {discountedCost}");
            Console.WriteLine($"The total delivery cost for volume-based delivery is: {volumeBasedCost}");
        }
    }
}