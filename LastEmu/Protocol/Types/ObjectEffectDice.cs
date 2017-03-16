using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffectDice : ObjectEffect
	{
		public const short Id = 73;

		public uint diceNum;

		public uint diceSide;

		public uint diceConst;

		public override short TypeId
		{
			get
			{
				return 73;
			}
		}

		public ObjectEffectDice()
		{
		}

		public ObjectEffectDice(uint actionId, uint diceNum, uint diceSide, uint diceConst) : base(actionId)
		{
			this.diceNum = diceNum;
			this.diceSide = diceSide;
			this.diceConst = diceConst;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.diceNum = reader.ReadVarUhShort();
			this.diceSide = reader.ReadVarUhShort();
			this.diceConst = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.diceNum);
			writer.WriteVarShort((int)this.diceSide);
			writer.WriteVarShort((int)this.diceConst);
		}
	}
}