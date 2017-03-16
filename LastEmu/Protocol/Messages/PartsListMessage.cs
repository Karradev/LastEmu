using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartsListMessage : NetworkMessage
	{
		public const uint Id = 1502;

		public ContentPart[] parts;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1502;
			}
		}

		public PartsListMessage()
		{
		}

		public PartsListMessage(ContentPart[] parts)
		{
			this.parts = parts;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.parts = new ContentPart[num];
			for (int i = 0; i < num; i++)
			{
				this.parts[i] = new ContentPart();
				this.parts[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.parts.Length));
			ContentPart[] contentPartArray = this.parts;
			for (int i = 0; i < (int)contentPartArray.Length; i++)
			{
				contentPartArray[i].Serialize(writer);
			}
		}
	}
}