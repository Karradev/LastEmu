using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TaxCollectorMovementRemoveMessage : NetworkMessage
	{
		public const uint Id = 5915;

		public int collectorId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5915;
			}
		}

		public TaxCollectorMovementRemoveMessage()
		{
		}

		public TaxCollectorMovementRemoveMessage(int collectorId)
		{
			this.collectorId = collectorId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.collectorId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.collectorId);
		}
	}
}