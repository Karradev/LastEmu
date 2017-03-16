using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class StatedMapUpdateMessage : NetworkMessage
	{
		public const uint Id = 5716;

		public StatedElement[] statedElements;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5716;
			}
		}

		public StatedMapUpdateMessage()
		{
		}

		public StatedMapUpdateMessage(StatedElement[] statedElements)
		{
			this.statedElements = statedElements;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.statedElements = new StatedElement[num];
			for (int i = 0; i < num; i++)
			{
				this.statedElements[i] = new StatedElement();
				this.statedElements[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.statedElements.Length));
			StatedElement[] statedElementArray = this.statedElements;
			for (int i = 0; i < (int)statedElementArray.Length; i++)
			{
				statedElementArray[i].Serialize(writer);
			}
		}
	}
}