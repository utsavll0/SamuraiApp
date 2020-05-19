using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
    public class SamuraiBattle
    {
        public int SamuraiId { get; set; } //foreign key
        public int BattleId { get; set; } //foreign key
        public Samurai Samurai { get; set; }
        public Battle Battle { get; set; }
    }
}
