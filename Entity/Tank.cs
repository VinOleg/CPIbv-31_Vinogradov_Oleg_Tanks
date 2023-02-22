using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ЦПИбв_31_Виноградов_Олег_Танки.Enum.TankEn;

namespace ЦПИбв_31_Виноградов_Олег_Танки.Entity
{
    /// <summary>
    /// Сущность танка
    /// </summary>
    public class Tank
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// Жизни танка
        /// </summary>
        public int HP { get; set; }

        /// <summary>
        /// Урон танка
        /// </summary>
        public int Damage { get; set; }

        /// <summary>
        /// Команда (в будущем хочу сделать систему опознования свой - Чужой)
        /// </summary>
        public Team Team { get; set; }

        /// <summary>
        /// Тип пушки в данный момент (Тоже интересная механика если вдруг до неё дойдет в сл. лабах)
        /// </summary>
        public TypeWeapon TypeWeapon { get; set; }

        public void Init(int speed, int hp, int damage, TypeWeapon typeweapon, Team team)
        {
            Speed = speed;
            HP = hp;
            Damage = damage;
            Team = team;
            TypeWeapon = typeweapon;
        }
    }
}
