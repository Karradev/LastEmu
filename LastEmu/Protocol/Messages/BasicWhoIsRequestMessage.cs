using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicWhoIsRequestMessage : NetworkMessage
	{
		public const uint Id = 181;

		public bool verbose;

		public string search;

		public override uint ProtocolId
		{
			get
			{
				return (uint)181;
			}
		}

		public BasicWhoIsRequestMessage()
		{
		}

		public BasicWhoIsRequestMessage(bool verbose, string search)
		{
			this.verbose = verbose;
			this.search = search;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.verbose = reader.ReadBoolean();
			this.search = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.verbose);
			writer.WriteUTF(this.search);
		}
	}
}