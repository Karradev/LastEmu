using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AggregateStatMessage : NetworkMessage
	{
		public const uint Id = 6669;

		public uint statId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6669;
			}
		}

		public AggregateStatMessage()
		{
		}

		public AggregateStatMessage(uint statId)
		{
			this.statId = statId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.statId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.statId);
		}
	}
}