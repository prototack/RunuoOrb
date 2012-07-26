using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class ABrokenVaseQuest : BaseQuest
	{				
		/*A Broken Vase */
		public override object Title{ get{ return 1112795; } }
		
		public override object Description{ get{ return 1112917; } }
		
		public override object Refuse{ get{ return 1112918; } }
		
		public override object Uncomplete{ get{ return 1112919; } }

        public override object Complete { get { return 1112920; } }
	
		public ABrokenVaseQuest() : base()

		{
            AddObjective(new ObtainObjective(typeof(AncientPotteryFragments), "Ancient Pottery Fragments", 10, 0x223B));
			
			AddReward( new BaseReward( typeof( MeagerMuseumBag ), 1112993 ) );
		}

       // public override void GiveRewards()
       // {
          // if ( Owner is PlayerMobile ) 
          // ((PlayerMobile)Owner).Exp += 50;
          //// Owner.SendMessage("You have also been awarded 5 Queens Loyalty Points!");
          // base.GiveRewards();
       // }
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}		
	}
	
	public class PuttingThePiecesTogetherQuest : BaseQuest
	{				
		/* Putting The Pieces Together */
		public override object Title{ get{ return 1112796; } }
		
		public override object Description{ get{ return 1112921; } }
		
		public override object Refuse{ get{ return 1112922; } }
		
		public override object Uncomplete{ get{ return 1112923; } }

        public override object Complete { get { return 1112924; } }
	
		public PuttingThePiecesTogetherQuest() : base()
		{
            AddObjective(new ObtainObjective(typeof(TatteredAncientScroll), "Tattered Ancient Scrolls", 5, 0x2F5F));
			
			AddReward( new BaseReward( typeof( DustyMuseumBag ), 1112994 ) );
		}

       // public override void GiveRewards()
       // {
           // if (Owner is PlayerMobile)
           // ((PlayerMobile)Owner).Exp += 100;
           // Owner.SendMessage("You have also been awarded 10 Queens Loyalty Points!");
           // base.GiveRewards();
       // }
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}		
	}
	
	public class YeOldeGargishQuest : BaseQuest
	{				
		/* Ye Olde Gargish */
		public override object Title{ get{ return 1112797; } }
		
		public override object Description{ get{ return 1112925; } }
		
		public override object Refuse{ get{ return 1112926; } }
		
		public override object Uncomplete{ get{ return 1112927; } }

        public override object Complete { get { return 1112928; } }
	
		public YeOldeGargishQuest() : base()
		{
            AddObjective(new ObtainObjective(typeof(UntransTome), "Untranslated Ancient Tome", 1, 0xEFA));
					
			AddReward( new BaseReward( typeof( BulgingMuseumBag ), 1112995 ) );
		}

       /// public override void GiveRewards()
       // {
           // if (Owner is PlayerMobile)
           // ((PlayerMobile)Owner).Exp += 500;
           // Owner.SendMessage("You have also been awarded 50 Queens Loyalty Points!");
           // base.GiveRewards();
       // }
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}		
	}
		
	public class Axem : MondainQuester
	{
		public override Type[] Quests
		{ 
			get{ return new Type[] 
			{ 
				typeof( ABrokenVaseQuest ),
				typeof( PuttingThePiecesTogetherQuest ),
				typeof( YeOldeGargishQuest ),
			};} 
		}
		
		[Constructable]
		public Axem() : base( "Axem", "the Curator" )
		{			
			SetSkill( SkillName.Meditation, 60.0, 83.0 );
			SetSkill( SkillName.Focus, 60.0, 83.0 );
		}
		
		public Axem( Serial serial ) : base( serial )
		{
		}

        public override void InitBody()
        {
            InitStats(100, 100, 25);

            Female = false;
            CantWalk = true;
            Body = 666;
            HairItemID = 16987;
            HairHue = 1801;
        }

        public override void InitOutfit()
        {
            AddItem(new Backpack());

            AddItem(new GargishClothChest(Utility.RandomNeutralHue()));
            AddItem(new GargishClothKilt(Utility.RandomNeutralHue()));
            AddItem(new GargishClothLegs(Utility.RandomNeutralHue()));
        }
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}