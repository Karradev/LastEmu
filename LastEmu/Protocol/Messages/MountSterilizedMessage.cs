using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountSterilizedMessage : NetworkMessage
	{
		public const uint Id = 5977;

		public int mountId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5977;
			}
		}

		public MountSterilizedMessage()
		{
		}

		public MountSterilizedMessage(int mountId)
		{
			this.mountId = mountId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mountId = reader.ReadVarInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(this.mountId);
		}
	}
}