using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameEntitiesDispositionMessage : NetworkMessage
	{
		public const uint Id = 5696;

		public IdentifiedEntityDispositionInformations[] dispositions;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5696;
			}
		}

		public GameEntitiesDispositionMessage()
		{
		}

		public GameEntitiesDispositionMessage(IdentifiedEntityDispositionInformations[] dispositions)
		{
			this.dispositions = dispositions;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.dispositions = new IdentifiedEntityDispositionInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.dispositions[i] = new IdentifiedEntityDispositionInformations();
				this.dispositions[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.dispositions.Length));
			IdentifiedEntityDispositionInformations[] identifiedEntityDispositionInformationsArray = this.dispositions;
			for (int i = 0; i < (int)identifiedEntityDispositionInformationsArray.Length; i++)
			{
				identifiedEntityDispositionInformationsArray[i].Serialize(writer);
			}
		}
	}
}