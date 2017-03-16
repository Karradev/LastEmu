using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class QuestStepInfoMessage : NetworkMessage
	{
		public const uint Id = 5625;

		public QuestActiveInformations infos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5625;
			}
		}

		public QuestStepInfoMessage()
		{
		}

		public QuestStepInfoMessage(QuestActiveInformations infos)
		{
			this.infos = infos;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.infos = ProtocolTypeManager.GetInstance<QuestActiveInformations>(reader.ReadUShort());
			this.infos.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.infos.TypeId);
			this.infos.Serialize(writer);
		}
	}
}