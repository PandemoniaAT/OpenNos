//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Character
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Character()
        {
            this.generallog = new HashSet<GeneralLog>();
            this.inventory = new HashSet<Inventory>();
            this.respawn = new HashSet<Respawn>();
            this.characterskill = new HashSet<CharacterSkill>();
            this.quicklist = new HashSet<QuicklistEntry>();
        }
    
        public long CharacterId { get; set; }
        public long AccountId { get; set; }
        public short MapId { get; set; }
        public string Name { get; set; }
        public byte Slot { get; set; }
        public byte Gender { get; set; }
        public byte Class { get; set; }
        public byte HairStyle { get; set; }
        public byte HairColor { get; set; }
        public short MapX { get; set; }
        public short MapY { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int ArenaWinner { get; set; }
        public long Reput { get; set; }
        public short Dignite { get; set; }
        public long Gold { get; set; }
        public int Backpack { get; set; }
        public byte Level { get; set; }
        public long LevelXp { get; set; }
        public byte HeroLvl { get; set; }
        public long HeroXp { get; set; }
        public long RagePoint { get; set; }
        public byte JobLevel { get; set; }
        public long JobLevelXp { get; set; }
        public int Act4Dead { get; set; }
        public int Act4Kill { get; set; }
        public int Faction { get; set; }
        public int SpPoint { get; set; }
        public int SpAdditionPoint { get; set; }
        public byte State { get; set; }
        public short Compliment { get; set; }
        public bool ExchangeBlocked { get; set; }
        public bool FriendRequestBlocked { get; set; }
        public bool WhisperBlocked { get; set; }
        public bool GroupRequestBlocked { get; set; }
        public bool MouseAimLock { get; set; }
        public bool HeroChatBlocked { get; set; }
        public bool EmoticonsBlocked { get; set; }
        public bool QuickGetUp { get; set; }
        public bool HpBlocked { get; set; }
        public bool BuffBlocked { get; set; }
        public bool MinilandInviteBlocked { get; set; }
        public bool FamilyRequestBlocked { get; set; }
        public int Act4Points { get; set; }
        public int TalentWin { get; set; }
        public int TalentLose { get; set; }
        public int TalentSurrender { get; set; }
        public int MasterPoints { get; set; }
        public int MasterTicket { get; set; }
    
        public virtual Account account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GeneralLog> generallog { get; set; }
        public virtual Map map { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> inventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Respawn> respawn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacterSkill> characterskill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuicklistEntry> quicklist { get; set; }
    }
}
