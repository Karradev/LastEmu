using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicStatMessage : NetworkMessage
	{
		public const uint Id = 6530;

		public double timeSpent;

		public uint statId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6530;
			}
		}

		public BasicStatMessage()
		{
		}

		public BasicStatMessage(double timeSpent, uint statId)
		{
			this.timeSpent = timeSpent;
			this.statId = statId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.timeSpent = reader.ReadDouble();
			this.statId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.timeSpent);
			writer.WriteVarShort((int)this.statId);
		}
	}
}