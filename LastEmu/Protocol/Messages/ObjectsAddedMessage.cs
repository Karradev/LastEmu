using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ObjectsAddedMessage : NetworkMessage
	{
		public const uint Id = 6033;

		public ObjectItem[] @object;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6033;
			}
		}

		public ObjectsAddedMessage()
		{
		}

		public ObjectsAddedMessage(ObjectItem[] @object)
		{
			this.@object = @object;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.@object = new ObjectItem[num];
			for (int i = 0; i < num; i++)
			{
				this.@object[i] = new ObjectItem();
				this.@object[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.@object.Length));
			ObjectItem[] obj = this.@object;
			for (int i = 0; i < (int)obj.Length; i++)
			{
				obj[i].Serialize(writer);
			}
		}
	}
}