namespace DiplomaTest
{
    public class OrderModel
    {
        public int Номер { get; set; }
        public string Артикул { get; set; }
        public string Штрих_код { get; set; }
        public string Имя { get; set; }
        public string Ед_изм { get; set; }
        public decimal Количество { get; set; }
        public int Шт_в_коробке { get; set; }
        public decimal Цена { get; set; }
        public decimal Сумма { get; set; }
    }
}
