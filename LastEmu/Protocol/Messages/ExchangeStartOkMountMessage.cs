using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkMountMessage : ExchangeStartOkMountWithOutPaddockMessage
	{
		public const uint Id = 5979;

		public MountClientData[] paddockedMountsDescription;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5979;
			}
		}

		public ExchangeStartOkMountMessage()
		{
		}

		public ExchangeStartOkMountMessage(MountClientData[] stabledMountsDescription, MountClientData[] paddockedMountsDescription) : base(stabledMountsDescription)
		{
			this.paddockedMountsDescription = paddockedMountsDescription;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.paddockedMountsDescription = new MountClientData[num];
			for (int i = 0; i < num; i++)
			{
				this.paddockedMountsDescription[i] = new MountClientData();
				this.paddockedMountsDescription[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.paddockedMountsDescription.Length));
			MountClientData[] mountClientDataArray = this.paddockedMountsDescription;
			for (int i = 0; i < (int)mountClientDataArray.Length; i++)
			{
				mountClientDataArray[i].Serialize(writer);
			}
		}
	}
}