using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountRenameRequestMessage : NetworkMessage
	{
		public const uint Id = 5987;

		public string name;

		public int mountId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5987;
			}
		}

		public MountRenameRequestMessage()
		{
		}

		public MountRenameRequestMessage(string name, int mountId)
		{
			this.name = name;
			this.mountId = mountId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.name = reader.ReadUTF();
			this.mountId = reader.ReadVarInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.name);
			writer.WriteVarInt(this.mountId);
		}
	}
}