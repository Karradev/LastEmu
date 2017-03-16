using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicWhoIsNoMatchMessage : NetworkMessage
	{
		public const uint Id = 179;

		public string search;

		public override uint ProtocolId
		{
			get
			{
				return (uint)179;
			}
		}

		public BasicWhoIsNoMatchMessage()
		{
		}

		public BasicWhoIsNoMatchMessage(string search)
		{
			this.search = search;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.search = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.search);
		}
	}
}