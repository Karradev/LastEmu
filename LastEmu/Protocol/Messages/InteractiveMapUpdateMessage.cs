using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class InteractiveMapUpdateMessage : NetworkMessage
	{
		public const uint Id = 5002;

		public InteractiveElement[] interactiveElements;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5002;
			}
		}

		public InteractiveMapUpdateMessage()
		{
		}

		public InteractiveMapUpdateMessage(InteractiveElement[] interactiveElements)
		{
			this.interactiveElements = interactiveElements;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.interactiveElements = new InteractiveElement[num];
			for (int i = 0; i < num; i++)
			{
				this.interactiveElements[i] = ProtocolTypeManager.GetInstance<InteractiveElement>(reader.ReadUShort());
				this.interactiveElements[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.interactiveElements.Length));
			InteractiveElement[] interactiveElementArray = this.interactiveElements;
			for (int i = 0; i < (int)interactiveElementArray.Length; i++)
			{
				InteractiveElement interactiveElement = interactiveElementArray[i];
				writer.WriteShort(interactiveElement.TypeId);
				interactiveElement.Serialize(writer);
			}
		}
	}
}