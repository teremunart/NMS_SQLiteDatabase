namespace No_Mans_Sky_Planetbase {
    public class SimpleData {
        public int GalaxyId { get; set; }
        public string GalaxyName { get; set; }
        
        public int SystemId { get; set; }
        public string SystemName { get; set; }
    }

    public class SystemData {
        public int SystemId { get; set; }
        public string SystemName { get; set; }
        
        public int GalaxyId { get; set; }
        
        public int PlanetCount { get; set; }
        public int MoonCount { get; set; }
        public int[] PlanetIds { get; set; }
        
        public string Species { get; set; }
        public string Economy { get; set; }
        public string Conflict { get; set; }
    }
}