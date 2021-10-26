namespace Infrastructure.Transactions.Constants
{
    public static class QueriesConstants
    {
        public const string MatchNodes = "MATCH (n)-[r]->(m) RETURN n,r,m";

        public const string CreateCharacter = 
            @"match (all_char:Character)
                match (all_item:Item)
            with {num_char: count(all_char), num_item: count(all_item)} as keys

            create (
                n:Character{
                id_pk:keys.num_char,
                id_breed_fk:0,
                id_class_fk:0,
                id_skills_fk:0,
                type_char:0,
                name:'Player1',
                caption: 'Player1',
                gender:'Male',
                level: 1
                })-[:has]->(
                    n2:Inventory{
                        id_pk:n.id_pk,
                        current_cap: 100,
                        max_cap: 200
                    })-[s:Stores{            
                        qty:1
                    }]->(i:Item{
                        id_pk:keys.num_item,
                        item_val:30,
                        item_rarity:1,
                        item_type: 0,
                        item_desc:'Armadura Leve'
                    });";
        
    }
}