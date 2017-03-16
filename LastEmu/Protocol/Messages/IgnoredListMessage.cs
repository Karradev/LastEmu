using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class IgnoredListMessage : NetworkMessage
	{
		public const uint Id = 5674;

		public IgnoredInformations[] ignoredList;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5674;
			}
		}

		public IgnoredListMessage()
		{
		}

		public IgnoredListMessage(IgnoredInformations[] ignoredList)
		{
			this.ignoredList = ignoredList;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.ignoredList = new IgnoredInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.ignoredList[i] = ProtocolTypeManager.GetInstance<IgnoredInformations>(reader.ReadUShort());
				this.ignoredList[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.ignoredList.Length));
			IgnoredInformations[] ignoredInformationsArray = this.ignoredList;
			for (int i = 0; i < (int)ignoredInformationsArray.Length; i++)
			{
				IgnoredInformations ignoredInformation = ignoredInformationsArray[i];
				writer.WriteShort(ignoredInformation.TypeId);
				ignoredInformation.Serialize(writer);
			}
		}
	}
}