using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class DareReward
	{
		public const short Id = 505;

		public sbyte type;

		public uint monsterId;

		public uint kamas;

		public double dareId;

		public virtual short TypeId
		{
			get
			{
				return 505;
			}
		}

		public DareReward()
		{
		}

		public DareReward(sbyte type, uint monsterId, uint kamas, double dareId)
		{
			this.type = type;
			this.monsterId = monsterId;
			this.kamas = kamas;
			this.dareId = dareId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadSByte();
			this.monsterId = reader.ReadVarUhShort();
			this.kamas = reader.ReadUInt();
			this.dareId = reader.ReadDouble();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.type);
			writer.WriteVarShort((int)this.monsterId);
			writer.WriteUInt(this.kamas);
			writer.WriteDouble(this.dareId);
		}
	}
}