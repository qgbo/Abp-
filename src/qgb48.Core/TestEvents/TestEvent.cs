using Abp.Events.Bus;


namespace qgb48.Tests
{
    /// <summary>
    /// 自定义事件，
    /// </summary>
    public class TestEvent: EventData
    {
        public int Id { get; set; }


        public string Name { get; set; }

        public int Age { get; set; }
    }
}
