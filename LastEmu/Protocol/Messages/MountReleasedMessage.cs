using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountReleasedMessage : NetworkMessage
	{
		public const uint Id = 6308;

		public int mountId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6308;
			}
		}

		public MountReleasedMessage()
		{
		}

		public MountReleasedMessage(int mountId)
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