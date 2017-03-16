using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class StartupActionAddObject
	{
		public const short Id = 52;

		public int uid;

		public string title;

		public string text;

		public string descUrl;

		public string pictureUrl;

		public ObjectItemInformationWithQuantity[] items;

		public virtual short TypeId
		{
			get
			{
				return 52;
			}
		}

		public StartupActionAddObject()
		{
		}

		public StartupActionAddObject(int uid, string title, string text, string descUrl, string pictureUrl, ObjectItemInformationWithQuantity[] items)
		{
			this.uid = uid;
			this.title = title;
			this.text = text;
			this.descUrl = descUrl;
			this.pictureUrl = pictureUrl;
			this.items = items;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.uid = reader.ReadInt();
			this.title = reader.ReadUTF();
			this.text = reader.ReadUTF();
			this.descUrl = reader.ReadUTF();
			this.pictureUrl = reader.ReadUTF();
			ushort num = reader.ReadUShort();
			this.items = new ObjectItemInformationWithQuantity[num];
			for (int i = 0; i < num; i++)
			{
				this.items[i] = new ObjectItemInformationWithQuantity();
				this.items[i].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.uid);
			writer.WriteUTF(this.title);
			writer.WriteUTF(this.text);
			writer.WriteUTF(this.descUrl);
			writer.WriteUTF(this.pictureUrl);
			writer.WriteShort((short)((int)this.items.Length));
			ObjectItemInformationWithQuantity[] objectItemInformationWithQuantityArray = this.items;
			for (int i = 0; i < (int)objectItemInformationWithQuantityArray.Length; i++)
			{
				objectItemInformationWithQuantityArray[i].Serialize(writer);
			}
		}
	}
}