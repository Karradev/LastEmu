using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ChatServerCopyWithObjectMessage : ChatServerCopyMessage
	{
		public const uint Id = 884;

		public ObjectItem[] objects;

		public override uint ProtocolId
		{
			get
			{
				return (uint)884;
			}
		}

		public ChatServerCopyWithObjectMessage()
		{
		}

		public ChatServerCopyWithObjectMessage(sbyte channel, string content, int timestamp, string fingerprint, double receiverId, string receiverName, ObjectItem[] objects) : base(channel, content, timestamp, fingerprint, receiverId, receiverName)
		{
			this.objects = objects;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.objects = new ObjectItem[num];
			for (int i = 0; i < num; i++)
			{
				this.objects[i] = new ObjectItem();
				this.objects[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.objects.Length));
			ObjectItem[] objectItemArray = this.objects;
			for (int i = 0; i < (int)objectItemArray.Length; i++)
			{
				objectItemArray[i].Serialize(writer);
			}
		}
	}
}