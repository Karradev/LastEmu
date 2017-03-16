using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TaxCollectorStateUpdateMessage : NetworkMessage
	{
		public const uint Id = 6455;

		public int uniqueId;

		public sbyte state;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6455;
			}
		}

		public TaxCollectorStateUpdateMessage()
		{
		}

		public TaxCollectorStateUpdateMessage(int uniqueId, sbyte state)
		{
			this.uniqueId = uniqueId;
			this.state = state;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.uniqueId = reader.ReadInt();
			this.state = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.uniqueId);
			writer.WriteSByte(this.state);
		}
	}
}