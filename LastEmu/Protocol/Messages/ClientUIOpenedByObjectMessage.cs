using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ClientUIOpenedByObjectMessage : ClientUIOpenedMessage
	{
		public const uint Id = 6463;

		public uint uid;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6463;
			}
		}

		public ClientUIOpenedByObjectMessage()
		{
		}

		public ClientUIOpenedByObjectMessage(sbyte type, uint uid) : base(type)
		{
			this.uid = uid;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.uid = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.uid);
		}
	}
}