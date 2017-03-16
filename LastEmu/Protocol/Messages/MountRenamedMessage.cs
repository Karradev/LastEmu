using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountRenamedMessage : NetworkMessage
	{
		public const uint Id = 5983;

		public int mountId;

		public string name;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5983;
			}
		}

		public MountRenamedMessage()
		{
		}

		public MountRenamedMessage(int mountId, string name)
		{
			this.mountId = mountId;
			this.name = name;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mountId = reader.ReadVarInt();
			this.name = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(this.mountId);
			writer.WriteUTF(this.name);
		}
	}
}