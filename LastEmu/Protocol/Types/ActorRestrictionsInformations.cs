using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class ActorRestrictionsInformations
	{
		public const short Id = 204;

		public bool cantBeAggressed;

		public bool cantBeChallenged;

		public bool cantTrade;

		public bool cantBeAttackedByMutant;

		public bool cantRun;

		public bool forceSlowWalk;

		public bool cantMinimize;

		public bool cantMove;

		public bool cantAggress;

		public bool cantChallenge;

		public bool cantExchange;

		public bool cantAttack;

		public bool cantChat;

		public bool cantBeMerchant;

		public bool cantUseObject;

		public bool cantUseTaxCollector;

		public bool cantUseInteractive;

		public bool cantSpeakToNPC;

		public bool cantChangeZone;

		public bool cantAttackMonster;

		public bool cantWalk8Directions;

		public virtual short TypeId
		{
			get
			{
				return 204;
			}
		}

		public ActorRestrictionsInformations()
		{
		}

		public ActorRestrictionsInformations(bool cantBeAggressed, bool cantBeChallenged, bool cantTrade, bool cantBeAttackedByMutant, bool cantRun, bool forceSlowWalk, bool cantMinimize, bool cantMove, bool cantAggress, bool cantChallenge, bool cantExchange, bool cantAttack, bool cantChat, bool cantBeMerchant, bool cantUseObject, bool cantUseTaxCollector, bool cantUseInteractive, bool cantSpeakToNPC, bool cantChangeZone, bool cantAttackMonster, bool cantWalk8Directions)
		{
			this.cantBeAggressed = cantBeAggressed;
			this.cantBeChallenged = cantBeChallenged;
			this.cantTrade = cantTrade;
			this.cantBeAttackedByMutant = cantBeAttackedByMutant;
			this.cantRun = cantRun;
			this.forceSlowWalk = forceSlowWalk;
			this.cantMinimize = cantMinimize;
			this.cantMove = cantMove;
			this.cantAggress = cantAggress;
			this.cantChallenge = cantChallenge;
			this.cantExchange = cantExchange;
			this.cantAttack = cantAttack;
			this.cantChat = cantChat;
			this.cantBeMerchant = cantBeMerchant;
			this.cantUseObject = cantUseObject;
			this.cantUseTaxCollector = cantUseTaxCollector;
			this.cantUseInteractive = cantUseInteractive;
			this.cantSpeakToNPC = cantSpeakToNPC;
			this.cantChangeZone = cantChangeZone;
			this.cantAttackMonster = cantAttackMonster;
			this.cantWalk8Directions = cantWalk8Directions;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.cantBeAggressed = BooleanByteWrapper.GetFlag(num, 0);
			this.cantBeChallenged = BooleanByteWrapper.GetFlag(num, 1);
			this.cantTrade = BooleanByteWrapper.GetFlag(num, 2);
			this.cantBeAttackedByMutant = BooleanByteWrapper.GetFlag(num, 3);
			this.cantRun = BooleanByteWrapper.GetFlag(num, 4);
			this.forceSlowWalk = BooleanByteWrapper.GetFlag(num, 5);
			this.cantMinimize = BooleanByteWrapper.GetFlag(num, 6);
			this.cantMove = BooleanByteWrapper.GetFlag(num, 7);
			byte num1 = reader.ReadByte();
			this.cantAggress = BooleanByteWrapper.GetFlag(num1, 0);
			this.cantChallenge = BooleanByteWrapper.GetFlag(num1, 1);
			this.cantExchange = BooleanByteWrapper.GetFlag(num1, 2);
			this.cantAttack = BooleanByteWrapper.GetFlag(num1, 3);
			this.cantChat = BooleanByteWrapper.GetFlag(num1, 4);
			this.cantBeMerchant = BooleanByteWrapper.GetFlag(num1, 5);
			this.cantUseObject = BooleanByteWrapper.GetFlag(num1, 6);
			this.cantUseTaxCollector = BooleanByteWrapper.GetFlag(num1, 7);
			byte num2 = reader.ReadByte();
			this.cantUseInteractive = BooleanByteWrapper.GetFlag(num2, 0);
			this.cantSpeakToNPC = BooleanByteWrapper.GetFlag(num2, 1);
			this.cantChangeZone = BooleanByteWrapper.GetFlag(num2, 2);
			this.cantAttackMonster = BooleanByteWrapper.GetFlag(num2, 3);
			this.cantWalk8Directions = BooleanByteWrapper.GetFlag(num2, 4);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.cantBeAggressed);
			num = BooleanByteWrapper.SetFlag(num, 1, this.cantBeChallenged);
			num = BooleanByteWrapper.SetFlag(num, 2, this.cantTrade);
			num = BooleanByteWrapper.SetFlag(num, 3, this.cantBeAttackedByMutant);
			num = BooleanByteWrapper.SetFlag(num, 4, this.cantRun);
			num = BooleanByteWrapper.SetFlag(num, 5, this.forceSlowWalk);
			num = BooleanByteWrapper.SetFlag(num, 6, this.cantMinimize);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 7, this.cantMove));
			byte num1 = BooleanByteWrapper.SetFlag(0, 0, this.cantAggress);
			num1 = BooleanByteWrapper.SetFlag(num1, 1, this.cantChallenge);
			num1 = BooleanByteWrapper.SetFlag(num1, 2, this.cantExchange);
			num1 = BooleanByteWrapper.SetFlag(num1, 3, this.cantAttack);
			num1 = BooleanByteWrapper.SetFlag(num1, 4, this.cantChat);
			num1 = BooleanByteWrapper.SetFlag(num1, 5, this.cantBeMerchant);
			num1 = BooleanByteWrapper.SetFlag(num1, 6, this.cantUseObject);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num1, 7, this.cantUseTaxCollector));
			byte num2 = BooleanByteWrapper.SetFlag(0, 0, this.cantUseInteractive);
			num2 = BooleanByteWrapper.SetFlag(num2, 1, this.cantSpeakToNPC);
			num2 = BooleanByteWrapper.SetFlag(num2, 2, this.cantChangeZone);
			num2 = BooleanByteWrapper.SetFlag(num2, 3, this.cantAttackMonster);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num2, 4, this.cantWalk8Directions));
		}
	}
}