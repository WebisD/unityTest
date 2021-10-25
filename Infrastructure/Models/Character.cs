namespace Infrastructure.Models
{
    public class Character
    {
        public int Id_Pk { get; set; }

        public int Id_Class_Fk { get; set; }

        public int Life_Pts { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Level { get; set; }

        public int Def_Pts { get; set; }

        public int Atk_Pts { get; set; }

        public int Id_Breed_Fk { get; set; }
        
    }
}