using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ContentPart
	{
		public const short Id = 350;

		public string id;

		public sbyte state;

		public virtual short TypeId
		{
			get
			{
				return 350;
			}
		}

		public ContentPart()
		{
		}

		public ContentPart(string id, sbyte state)
		{
			this.id = id;
			this.state = state;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadUTF();
			this.state = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.id);
			writer.WriteSByte(this.state);
		}
	}
}