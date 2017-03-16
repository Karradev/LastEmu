using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ContactLookRequestByNameMessage : ContactLookRequestMessage
	{
		public const uint Id = 5933;

		public string playerName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5933;
			}
		}

		public ContactLookRequestByNameMessage()
		{
		}

		public ContactLookRequestByNameMessage(byte requestId, sbyte contactType, string playerName) : base(requestId, contactType)
		{
			this.playerName = playerName;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.playerName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.playerName);
		}
	}
}