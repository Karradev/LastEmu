using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PartyIdol : Idol
	{
		public const short Id = 490;

		public double[] ownersIds;

		public override short TypeId
		{
			get
			{
				return 490;
			}
		}

		public PartyIdol()
		{
		}

		public PartyIdol(uint id, uint xpBonusPercent, uint dropBonusPercent, double[] ownersIds) : base(id, xpBonusPercent, dropBonusPercent)
		{
			this.ownersIds = ownersIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.ownersIds = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.ownersIds[i] = reader.ReadVarUhLong();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.ownersIds.Length));
			double[] numArray = this.ownersIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarLong(numArray[i]);
			}
		}
	}
}