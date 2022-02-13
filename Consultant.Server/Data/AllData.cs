using Consultant.Shared.Entity.Api;

namespace Consultant.Server.Data
{
    public static class AllData
    {
        public static IReadOnlyDictionary<Guid, Product> Products = new Dictionary<Guid, Product>()
        {
            {
                new Guid("B8CE3274-F70F-4CA7-81D8-1BCC00BB0FE6"),
                new Product
                {
                    ProductID = new Guid("B8CE3274-F70F-4CA7-81D8-1BCC00BB0FE6"),
                    Name = "Молоко 3,5 % топленое 450 мл Залесский Фермер",
                    Description = "Для приготовления используется молоко с собственных ферм.",
                    Price = 44.90f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzIzNzExMy9vcmlnaW5hbC8yMDc2NDUuanBnPzE2MTUzOTcyNzI.png"
                } 
            },
            {
                new Guid("99DB3672-87B1-4911-A56A-3CE9C15CBE74"),
                new Product
                {
                    ProductID = new Guid("99DB3672-87B1-4911-A56A-3CE9C15CBE74"),
                    Name = "Молочный коктейль ФрутоНяня малина 2,1% 200 мл",
                    Description = "Изготовлены по особым рецептам из специально отобранных натуральных ингредиентов высшего качества. Молочные коктейли «ФрутоНяня» — полезное лакомство для детей.",
                    Price = 42.49f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzkwNzkxL29yaWdpbmFsLzQxMjY4LnBuZz8xNjI0ODE0ODA2.jpg"
                }
            },
            {
                new Guid("7595BADA-1412-4FB6-AE3D-80D6C090F752"),
                new Product
                {
                    ProductID = new Guid("7595BADA-1412-4FB6-AE3D-80D6C090F752"),
                    Name = "Филе без кожи Куриное Царство замороженное ~900 г",
                    Description = "",
                    Price = 310.50f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzc3NTk0MS9vcmlnaW5hbC82NzY5MTUuanBnPzE2MDM3ODczNjk.png"
                }
            },
            {
                new Guid("0A0ED8F2-1ADA-40CD-AA7E-76867A5E6F60"),
                new Product
                {
                    ProductID = new Guid("0A0ED8F2-1ADA-40CD-AA7E-76867A5E6F60"),
                    Name = "Чипсы картофельные Lay's Из печи лисички в сметане 85 г",
                    Description = "Lay's Из печи Лисички в сметане - яркий вкус грибов, аппетитный хруст чипсов, а самое главное на 50% меньше жира! Эти новые чипсы запекаются в печи по уникальной технологии и содержат меньше масла. Теперь любимый перекус может радовать тебя чаще!",
                    Price = 99.79f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzIxODc0MC9vcmlnaW5hbC8xMDg3ODRfMS5qcGc_MTYzOTkyNzEzMA.png"
                }
            },
            {
                new Guid("0C80AF6E-CE59-404D-BE57-743195E11151"),
                new Product
                {
                    ProductID = new Guid("0C80AF6E-CE59-404D-BE57-743195E11151"),
                    Name = "Сухарики ржаные Хрусteam холодец с хреном 40 г",
                    Description = "Сухарики с легким хрустом – прекрасно подойдут, когда хочется перекусить.",
                    Price = 19.99f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzIzNjQzNjgvb3JpZ2luYWwvMTM3NDM5XzEuanBnPzE2Mzk5MzI2NDI.png"
                }
            },
            {
                new Guid("61A62BF3-3506-4977-AD4E-1DE7EF587AFA"),
                new Product
                {
                    ProductID = new Guid("61A62BF3-3506-4977-AD4E-1DE7EF587AFA"),
                    Name = "Шпроты крупные Вкусные консервы в масле 160 г",
                    Description = "Шпроты ВКУСНЫЕ КОНСЕРВЫ крупные, 160г имеют классический приятный аромат и сбалансированную консистенцию. Продукт готовится по традиционному рецепту, рыбка коптится в дровяной печи, благодаря чему консервы получаются такими вкусными.Шпроты имеют одинаковый размер, они умеренно политы маслом и не слипаются. Консервированный продукт создан только из натуральных ингредиентов.Шпроты прекрасно подойдут как для приготовления домашних бутербродов, так и для создания салатов и других блюд. Удобная железная упаковка с ключом в форме кольца легко открывается и комфортно хранится в течение длительного времени.",
                    Price = 131.00f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzIyMzkzMi9vcmlnaW5hbC84MTgwNF8xLmpwZz8xNjM5OTI3Nzcx.png"
                }
            },
            {
                new Guid("16576257-0ACE-4F9D-B88D-310B605AF3BA"),
                new Product
                {
                    ProductID = new Guid("16576257-0ACE-4F9D-B88D-310B605AF3BA"),
                    Name = "Круассаны 7 Days Мини с двойной начинкой ваниль-вишня 300 г",
                    Description = "Сочетание нежного сладкого крема «ваниль» и кислого вкуса вишневого джемы собственного производства создает уникальный дуэт вкусов в каждом мини круассане 7DAYS! Мини круассаны 7DAYS 300г идеальное решение, чтобы разделить лучшие моменты дня с родными и друзьями. Мини круассаны 7DAYS – это много маленьких вкусных круассанов в одной упаковке. Множество воздушных слоев и разнообразие кремовых и джемовых начинок никого не оставят равнодушным! Дома или на работе, в одиночестве или с друзьями, насладитесь кофе с мини круассанами 7DAYS и сделайте ваши повседневные моменты особенными!любимых Мини круассанов 7DAYS, если хочется побаловать себя!",
                    Price = 136.00f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzIxNTMxNy9vcmlnaW5hbC82MTc1Ml8xLmpwZz8xNjQwMDE1Mzg4.png"
                }
            },
            {
                new Guid("6B885DC6-CD3A-4860-8F4C-FC4C0B18B7A7"),
                new Product
                {
                    ProductID = new Guid("6B885DC6-CD3A-4860-8F4C-FC4C0B18B7A7"),
                    Name = "Сушки Семейка Озби кроха с ванилью 200 г",
                    Description = "Нельзя представить себе традиционное русское чаепитие без сушек. Сушка – старинное славянское кулинарное изделие из теста. Сушки приобрели широкую популярность благодаря неприхотливости и способности подолгу и без потерь сохранять свои вкусовые, питательные и эстетические качества. Сушки Семейка ОЗБИ изготовлены классическим способом тестоприготовления с использованием опары и соблюдением всех необходимых технологических характеристик и параметров.",
                    Price = 39.00f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzIzOTA5My9vcmlnaW5hbC8xMTQ2ODJfMS5qcGc_MTY0MDAxNDgzOA.png"
                }
            },
            {
                new Guid("D5F64863-8164-44B6-8997-B543A18A2A35"),
                new Product
                {
                    ProductID = new Guid("D5F64863-8164-44B6-8997-B543A18A2A35"),
                    Name = "Салат Латук Metro Chef Премиум в горшочке 75 г",
                    Description = "Metro Cash&Carry; – это имя стоит за одной из величайших историй успеха в современной торговле. На протяжении почти более 50 лет компания предлагает профессиональным клиентам широчайший ассортимент товаров, специально подобранных для их нужд.",
                    Price = 99.90f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzMxNTIzNjIvb3JpZ2luYWwvMTc0MTU4NjUuanBnPzE2MzY3ODgzNjU.png"
                }
            },
            {
                new Guid("8D837162-A944-4164-8E2A-2357AD68E6F8"),
                new Product
                {
                    ProductID = new Guid("8D837162-A944-4164-8E2A-2357AD68E6F8"),
                    Name = "Газированный напиток Coca-Cola 1,5 л",
                    Description = "Coca-Cola - любимый напиток миллионов.Продукт одноименной компании стал легендой. Вы можете любить его или нет, но пробовали напиток хотя бы раз в жизни.Вкусная, ароматная, бодрящая, кока-кола всегда доставит Вам удовольствие!",
                    Price = 131.00f,
                    ImageUrl = "https://imgproxy.sbermarket.ru/imgproxy/size-1646-1646/aHR0cHM6Ly9zYmVybWFya2V0LnJ1L3NwcmVlL3Byb2R1Y3RzLzk5Nzk1L29yaWdpbmFsLzU5OTkzXzEuanBnPzE2NDA3NzAzNDA.png"
                }
            }
        };
    }
}
