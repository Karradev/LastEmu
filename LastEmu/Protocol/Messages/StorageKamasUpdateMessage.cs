using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class StorageKamasUpdateMessage : NetworkMessage
	{
		public const uint Id = 5645;

		public int kamasTotal;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5645;
			}
		}

		public StorageKamasUpdateMessage()
		{
		}

		public StorageKamasUpdateMessage(int kamasTotal)
		{
			this.kamasTotal = kamasTotal;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.kamasTotal = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.kamasTotal);
		}
	}
}