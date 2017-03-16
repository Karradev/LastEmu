using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class StatsUpgradeResultMessage : NetworkMessage
	{
		public const uint Id = 5609;

		public sbyte result;

		public uint nbCharacBoost;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5609;
			}
		}

		public StatsUpgradeResultMessage()
		{
		}

		public StatsUpgradeResultMessage(sbyte result, uint nbCharacBoost)
		{
			this.result = result;
			this.nbCharacBoost = nbCharacBoost;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.result = reader.ReadSByte();
			this.nbCharacBoost = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.result);
			writer.WriteVarShort((int)this.nbCharacBoost);
		}
	}
}