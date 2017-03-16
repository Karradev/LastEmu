using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountInformationInPaddockRequestMessage : NetworkMessage
	{
		public const uint Id = 5975;

		public int mapRideId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5975;
			}
		}

		public MountInformationInPaddockRequestMessage()
		{
		}

		public MountInformationInPaddockRequestMessage(int mapRideId)
		{
			this.mapRideId = mapRideId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mapRideId = reader.ReadVarInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(this.mapRideId);
		}
	}
}